using Before = Benchmark.Before;
using After = Benchmark.After;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Linq;
using System.Text;

namespace BenchmarkTesting.App
{
    public class Program
    {
        [Benchmark]
        public string AppendThousandStringsWithPlusOperator()
        {
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                result += "NewString";
            }
            return result;
        }

        [Benchmark]
        public string AppendThousandStringsWithConcatCommand()
        {
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                result.Concat("NewString");
            }
            return result.ToString();
        }

        [Benchmark]
        public string AppendThousandStringsWithStringBuilder()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                result.Append("NewString");
            }
            return result.ToString();
        }

        [Benchmark]
        public void ASPDotNetCoreSimpleExample_BeforeUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                Before.Processing.ProcessYaml(Examples.ASPDotNetCoreSimpleExample());
            }
        }

        [Benchmark]
        public void DotNetFrameworkDesktopExample_BeforeUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                Before.Processing.ProcessYaml(Examples.DotNetFrameworkDesktopExample());
            }
        }

        [Benchmark]
        public void ASPDotNetFrameworkExample_BeforeUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                Before.Processing.ProcessYaml(Examples.ASPDotNetFrameworkExample());
            }
        }

        [Benchmark]
        public void NodeExample_BeforeUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                Before.Processing.ProcessYaml(Examples.NodeExample());
            }
        }

        [Benchmark]
        public void CIExample_BeforeUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                Before.Processing.ProcessYaml(Examples.CIExample());
            }
        }

        [Benchmark]
        public void CDExample_BeforeUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                Before.Processing.ProcessYaml(Examples.CDExample());
            }
        }

        [Benchmark]
        public void CICDExample_BeforeUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                Before.Processing.ProcessYaml(Examples.CICDExample());
            }
        }

        [Benchmark]
        public void ContainerExample_BeforeUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                Before.Processing.ProcessYaml(Examples.ContainerExample());
            }
        }

        [Benchmark]
        public void AntExample_BeforeUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                Before.Processing.ProcessYaml(Examples.AntExample());
            }
        }

        [Benchmark]
        public void GradleExample_BeforeUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                Before.Processing.ProcessYaml(Examples.GradleExample());
            }
        }

        [Benchmark]
        public void MavenExample_BeforeUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                Before.Processing.ProcessYaml(Examples.MavenExample());
            }
        }

        [Benchmark]
        public void PythonExample_BeforeUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                Before.Processing.ProcessYaml(Examples.PythonExample());
            }
        }

        [Benchmark]
        public void RubyExample_BeforeUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                Before.Processing.ProcessYaml(Examples.RubyExample());
            }
        }

        [Benchmark]
        public void ASPDotNetCoreSimpleExample_AfterUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                After.Processing.ProcessYaml(Examples.ASPDotNetCoreSimpleExample());
            }
        }

        [Benchmark]
        public void DotNetFrameworkDesktopExample_AfterUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                After.Processing.ProcessYaml(Examples.DotNetFrameworkDesktopExample());
            }
        }

        [Benchmark]
        public void ASPDotNetFrameworkExample_AfterUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                After.Processing.ProcessYaml(Examples.ASPDotNetFrameworkExample());
            }
        }

        [Benchmark]
        public void NodeExample_AfterUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                After.Processing.ProcessYaml(Examples.NodeExample());
            }
        }

        [Benchmark]
        public void CIExample_AfterUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                After.Processing.ProcessYaml(Examples.CIExample());
            }
        }

        [Benchmark]
        public void CDExample_AfterUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                After.Processing.ProcessYaml(Examples.CDExample());
            }
        }

        [Benchmark]
        public void CICDExample_AfterUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                After.Processing.ProcessYaml(Examples.CICDExample());
            }
        }

        [Benchmark]
        public void ContainerExample_AfterUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                After.Processing.ProcessYaml(Examples.ContainerExample());
            }
        }

        [Benchmark]
        public void AntExample_AfterUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                After.Processing.ProcessYaml(Examples.AntExample());
            }
        }

        [Benchmark]
        public void GradleExample_AfterUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                After.Processing.ProcessYaml(Examples.GradleExample());
            }
        }

        [Benchmark]
        public void MavenExample_AfterUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                After.Processing.ProcessYaml(Examples.MavenExample());
            }
        }

        [Benchmark]
        public void PythonExample_AfterUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                After.Processing.ProcessYaml(Examples.PythonExample());
            }
        }

        [Benchmark]
        public void RubyExample_AfterUpgrade()
        {
            for (int i = 0; i < 10; i++)
            {
                After.Processing.ProcessYaml(Examples.RubyExample());
            }
        }

        public static void Main(string[] args)
        {
            //dotnet run -p BenchmarkTesting.App.csproj -c Release
            var summary = BenchmarkRunner.Run<Program>();
        }
    }
}
