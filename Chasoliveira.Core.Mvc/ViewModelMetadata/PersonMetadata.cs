using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Chasoliveira.Core.Mvc.ViewModel
{
    namespace Chasoliveira.Core.Application.DataTransferObject
    {

        [ModelMetadataType(typeof(PersonMetadata))]
        public partial class PersonDTO
        {
        }
    }
    public class PersonMetadata
    {

        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
    }

}