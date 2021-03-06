using System;
using System.Collections.Generic;

namespace Bio.IO.GenBank
{
    /// <summary>
    /// A related strain contains stable mutations from the same gene (e.g., RFLPs, polymorphisms, etc.) 
    /// which differ from the presented sequence at this location (and possibly others).
    /// </summary>
    public class Variation : FeatureItem
    {
        #region Constructors
        /// <summary>
        /// Creates new Variation feature item from the specified location.
        /// </summary>
        /// <param name="location">Location of the Variation.</param>
        public Variation(ILocation location)
            : base(StandardFeatureKeys.Variation, location) { }

        /// <summary>
        /// Creates new Variation feature item with the specified location.
        /// Note that this constructor uses LocationBuilder to construct location object from the specified 
        /// location string.
        /// </summary>
        /// <param name="location">Location of the Variation.</param>
        public Variation(string location)
            : base(StandardFeatureKeys.Variation, location) { }

        /// <summary>
        /// Private constructor for clone method.
        /// </summary>
        /// <param name="other">Other Variation instance.</param>
        private Variation(Variation other)
            : base(other) { }
        #endregion Constructors

        #region Properties

        /// <summary>
        /// Name of the allele for the given gene.
        /// All gene-related features (exon, CDS etc) for a given gene should share the same Allele qualifier value; 
        /// the Allele qualifier value must, by definition, be different from the Gene qualifier value; when used with 
        /// the variation feature key, the Allele qualifier value should be that of the variant.
        /// </summary>
        public string Allele
        {
            get
            {
                return GetSingleTextQualifier(StandardQualifierNames.Allele);
            }

            set
            {
                SetSingleTextQualifier(StandardQualifierNames.Allele, value);
            }
        }

        /// <summary>
        /// Reference to a citation listed in the entry reference field.
        /// </summary>
        public List<string> Citation
        {
            get
            {
                return GetQualifier(StandardQualifierNames.Citation);
            }
        }

        /// <summary>
        /// Reference details of an existing public INSD entry to which a comparison is made.
        /// </summary>
        public List<string> Compare
        {
            get
            {
                return GetQualifier(StandardQualifierNames.Compare);
            }
        }

        /// <summary>
        /// Database cross-reference: pointer to related information in another database.
        /// </summary>
        public List<string> DatabaseCrossReference
        {
            get
            {
                return GetQualifier(StandardQualifierNames.DatabaseCrossReference);
            }
        }

        /// <summary>
        /// A brief description of the nature of the experimental evidence that supports the feature 
        /// identification or assignment.
        /// </summary>
        public List<string> Experiment
        {
            get
            {
                return GetQualifier(StandardQualifierNames.Experiment);
            }
        }

        /// <summary>
        /// Frequency of the occurrence of a feature.
        /// </summary>
        public string Frequency
        {
            get
            {
                return GetSingleTextQualifier(StandardQualifierNames.Frequency);
            }

            set
            {
                SetSingleTextQualifier(StandardQualifierNames.Frequency, value);
            }
        }

        /// <summary>
        /// Symbol of the gene corresponding to a sequence region.
        /// </summary>
        public string GeneSymbol
        {
            get
            {
                return GetSingleTextQualifier(StandardQualifierNames.GeneSymbol);
            }

            set
            {
                SetSingleTextQualifier(StandardQualifierNames.GeneSymbol, value);
            }
        }

        /// <summary>
        /// Synonymous, replaced, obsolete or former gene symbol.
        /// </summary>
        public List<string> GeneSynonym
        {
            get
            {
                return GetQualifier(StandardQualifierNames.GeneSynonym);
            }
        }

        /// <summary>
        /// Genomic map position of feature.
        /// </summary>
        public string GenomicMapPosition
        {
            get
            {
                return GetSingleTextQualifier(StandardQualifierNames.GenomicMapPosition);
            }

            set
            {
                SetSingleTextQualifier(StandardQualifierNames.GenomicMapPosition, value);
            }
        }

        /// <summary>
        /// A structured description of non-experimental evidence that supports the feature 
        /// identification or assignment.
        /// </summary>
        public List<string> Inference
        {
            get
            {
                return GetQualifier(StandardQualifierNames.Inference);
            }
        }

        /// <summary>
        /// A submitter-supplied, systematic, stable identifier for a gene and its associated 
        /// features, used for tracking purposes.
        /// </summary>
        public List<string> LocusTag
        {
            get
            {
                return GetQualifier(StandardQualifierNames.LocusTag);
            }
        }

        /// <summary>
        /// Any comment or additional information.
        /// </summary>
        public List<string> Note
        {
            get
            {
                return GetQualifier(StandardQualifierNames.Note);
            }
        }

        /// <summary>
        /// Feature tag assigned for tracking purposes.
        /// </summary>
        public List<string> OldLocusTag
        {
            get
            {
                return GetQualifier(StandardQualifierNames.OldLocusTag);
            }
        }

        /// <summary>
        /// Phenotype conferred by the feature, where phenotype is defined as a physical, biochemical or behavioral 
        /// characteristic or set of characteristics.
        /// </summary>
        public List<string> Phenotype
        {
            get
            {
                return GetQualifier(StandardQualifierNames.Phenotype);
            }
        }

        /// <summary>
        /// Name of the product associated with the feature, e.g. the mRNA of an mRNA feature, 
        /// the polypeptide of a CDS, the mature peptide of a mat_peptide, etc.
        /// </summary>
        public List<string> Product
        {
            get
            {
                return GetQualifier(StandardQualifierNames.Product);
            }
        }

        /// <summary>
        /// Indicates that the sequence identified a feature's intervals is replaced by the sequence shown in ""text"";
        /// if no sequence is contained within the qualifier, this indicates a deletion.
        /// </summary>
        public string Replace
        {
            get
            {
                return GetSingleTextQualifier(StandardQualifierNames.Replace);
            }

            set
            {
                SetSingleTextQualifier(StandardQualifierNames.Replace, value);
            }
        }

        /// <summary>
        /// Accepted standard name for this feature.
        /// </summary>
        public string StandardName
        {
            get
            {
                return GetSingleTextQualifier(StandardQualifierNames.StandardName);
            }

            set
            {
                SetSingleTextQualifier(StandardQualifierNames.StandardName, value);
            }
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Creates a new Variation that is a copy of the current Variation.
        /// </summary>
        /// <returns>A new Variation that is a copy of this Variation.</returns>
        public new Variation Clone()
        {
            return new Variation(this);
        }
        #endregion Methods
    }
}
