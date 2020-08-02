using Core.Extensions;
using Microsoft.CSharp;
using Newtonsoft.Json;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Reflection;

namespace Core.Models
{
    public class JsonGenerator : Generator
    {
        public JsonGenerator(string className, string classNamespace, string content, string outputDirectory)
            : base(className, classNamespace, content, outputDirectory)
        {
        }

        public override void Generate()
        {
            var classType = new CodeTypeDeclaration(ClassName);
            classType.TypeAttributes = TypeAttributes.Public | TypeAttributes.Sealed;
            classType.IsClass = true;

            var fullConstructor = new CodeConstructor();
            fullConstructor.Attributes = MemberAttributes.Public;

            dynamic classObject = JsonConvert.DeserializeObject<ExpandoObject>(Content);
            IDictionary<string, object> propriedades = classObject;

            foreach (var propriedade in propriedades)
            {
                var field = new CodeMemberField(propriedade.Value.GetType(), propriedade.Key.FirstLetterToLower());
                field.Attributes = MemberAttributes.Private;

                var prop = GenerateProperty(field);

                AddFieldToConstructor(fullConstructor, field);
                classType.Members.Add(field);
                classType.Members.Add(prop);
            }

            var emptyConstructor = new CodeConstructor();
            emptyConstructor.Attributes = MemberAttributes.Public;

            classType.Members.Add(emptyConstructor);
            classType.Members.Add(fullConstructor);

            var codeNamespace = new CodeNamespace(ClassNamespace);
            codeNamespace.Types.Add(classType);

            Compile(codeNamespace);
        }

        public void Compile(CodeNamespace codeNamespace)
        {
            CodeCompileUnit compileUnit = new CodeCompileUnit();
            compileUnit.Namespaces.Add(codeNamespace);

            CSharpCodeProvider provider = new CSharpCodeProvider();

            var options = new CodeGeneratorOptions();
            options.BracingStyle = "C";

            string path = $"{OutputDirectory}\\{ClassName}.{provider.FileExtension}";

            using (var writer = new StreamWriter(path))
            {
                provider.GenerateCodeFromCompileUnit(compileUnit, writer, options);
            }
        }

        public CodeMemberProperty GenerateProperty(CodeMemberField field)
        {
            string fieldName = field.Name;

            var property = new CodeMemberProperty();
            property.Type = field.Type;
            property.Name = fieldName.FirstLetterToUpper();
            property.Attributes = MemberAttributes.Public | MemberAttributes.Final;

            var fieldReference = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName);
            var get = new CodeMethodReturnStatement(fieldReference);

            var set = new CodeAssignStatement(fieldReference, new CodePropertySetValueReferenceExpression());

            property.GetStatements.Add(get);
            property.SetStatements.Add(set);

            return property;
        }

        public void AddFieldToConstructor(CodeConstructor constructor, CodeMemberField field)
        {
            string fieldName = field.Name;

            var parameter = new CodeParameterDeclarationExpression(field.Type, fieldName);
            constructor.Parameters.Add(parameter);

            var fieldReference = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName);
            var assing = new CodeAssignStatement(fieldReference, new CodeArgumentReferenceExpression(fieldName));

            constructor.Statements.Add(assing);
        }
    }
}
