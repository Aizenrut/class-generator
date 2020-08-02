using Core.Interfaces;

namespace Core.Models
{
    public abstract class Generator : IGenerator
    {
        protected string ClassName { get; set; }
        protected string ClassNamespace { get; set; }
        protected string Content { get; set; }
        protected string OutputDirectory { get; set; }

        public Generator(string className, string classNamespace, string content, string outputDirectory)
        {
            ClassName = className;
            ClassNamespace = classNamespace;
            Content = content;
            OutputDirectory = outputDirectory;
        }

        public abstract void Generate();
    }
}
