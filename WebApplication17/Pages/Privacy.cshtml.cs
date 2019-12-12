using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication17.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("***************Privacy test****************");
            _logger.LogWarning("***************Privacy test****************");
        }
        public void onTest()
        {
            try
            {
                _logger.LogInformation("***************Privacy test****************");
               if(1==1)throw new InvalidOperationException("---test Exception------");
                
            }
            catch (Exception e)
            {
                _logger.LogError("***************Error test****************");
                _logger.LogWarning("***************Privacy test****************");
            }
        }
    }
}
