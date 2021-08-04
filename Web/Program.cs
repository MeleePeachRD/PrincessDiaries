using System.Threading.Tasks;
using Statiq.App;
using Statiq.Common;
using Statiq.Web;

namespace MeleePeachRD.PrincessDiaries.Web
{
    public static class Program
    {
        public static async Task<int> Main(string[] args) =>
            await Bootstrapper
                .Factory
                .CreateWeb(args)
                .DeployToGitHubPages(
                    @"MeleePeachRD",
                    @"PrincessDiaries",
                    Config.FromSetting<string>(@"GITHUB_TOKEN"))
                .RunAsync();
    }
}