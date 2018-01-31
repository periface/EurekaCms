using Abp.AutoMapper;
using Eureka.Cms.Sessions.Dto;

namespace Eureka.Cms.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}