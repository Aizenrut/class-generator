using Core.Enums;
using Core.Models;
using System;

namespace Core.Builders
{
    public class GeneratorBuilder
    {
        private GeneratorTypes generatorType;
        private string className;
        private string classNamespace;
        private string content;
        private string outputDirectory;

        public GeneratorBuilder ForGeneratorType(GeneratorTypes generatorType)
        {
            this.generatorType = generatorType;
            return this;
        }

        public GeneratorBuilder WithClassName(string className)
        {
            this.className = className;
            return this;
        }

        public GeneratorBuilder WithNamespace(string classNamespace)
        {
            this.classNamespace = classNamespace;
            return this;
        }

        public GeneratorBuilder WithContent(string content)
        {
            this.content = content;
            return this;
        }

        public GeneratorBuilder AtDirectory(string classPath)
        {
            this.outputDirectory = classPath;
            return this;
        }

        public Generator Build()
        {
            switch (generatorType)
            {
                case GeneratorTypes.JSON:
                    return new JsonGenerator(className, classNamespace, content, outputDirectory);
                case GeneratorTypes.XML:
                    throw new NotImplementedException("Função ainda não implementada!");
                default:
                    throw new ArgumentOutOfRangeException("O tipo de gerador informado não é válido!");
            }
        }
    }
}
