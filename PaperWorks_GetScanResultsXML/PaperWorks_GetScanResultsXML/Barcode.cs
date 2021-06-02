using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperWorks_GetScanResultsXML
{
    class Barcode : IEquatable<Barcode>
    {
        /* Getter */
        public string Code { get; }
        public BarcodeTypes Type { get; }

        public Barcode(string code, BarcodeTypes type)
        {
            Code = code;
            Type = type;
        }

        /* Equality members */
        public bool Equals(Barcode other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return Code == other.Code && Type == other.Type;
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Barcode)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                return ((Code != null ? Code.GetHashCode() : 0) * 397) ^ (int)Type;
            }
        }
        public static bool operator ==(Barcode left, Barcode right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(Barcode left, Barcode right)
        {
            return !Equals(left, right);
        }
    }
}
