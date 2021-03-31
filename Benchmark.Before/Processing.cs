using AzurePipelinesToGitHubActionsConverter.Core;
using System;

namespace Benchmark.Before
{
    public class Processing
    {
        public static string ProcessYaml(string yaml)
        {
            if (string.IsNullOrEmpty(yaml) == false)
            {
                yaml = yaml.TrimStart().TrimEnd();
            }

            //process the yaml
            ConversionResponse gitHubResult;
            try
            {
                Conversion conversion = new Conversion();
                gitHubResult = conversion.ConvertAzurePipelineToGitHubAction(yaml);
            }
            catch (YamlDotNet.Core.YamlException ex)
            {
                gitHubResult = new ConversionResponse
                {
                    actionsYaml = "Error processing YAML, it's likely the original YAML is not valid" + Environment.NewLine +
                    "Original error message: " + ex.ToString(),
                    pipelinesYaml = yaml
                };
            }
            catch (Exception ex)
            {
                gitHubResult = new ConversionResponse
                {
                    actionsYaml = "Unexpected error: " + ex.ToString(),
                    pipelinesYaml = yaml
                };
            }

            return gitHubResult.actionsYaml;
        }
    }
}
