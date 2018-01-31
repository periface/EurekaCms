using System.Threading.Tasks;
using Abp.Application.Services;
using Eureka.Cms.Configuration.Dto;

namespace Eureka.Cms.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}