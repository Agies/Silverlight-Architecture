
namespace SilverlightArchitecture.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies BusinessBaseMetadata as the class
    // that carries additional metadata for the BusinessBase class.
    [MetadataTypeAttribute(typeof(BusinessBase.BusinessBaseMetadata))]
    public partial class BusinessBase
    {

        // This class allows you to attach custom attributes to properties
        // of the BusinessBase class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class BusinessBaseMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private BusinessBaseMetadata()
            {
            }

            public string CreatedBy { get; set; }

            public DateTime CreatedDate { get; set; }

            public int Id { get; set; }
        }
    }
}
