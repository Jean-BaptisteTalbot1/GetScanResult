using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperWorks_GetScanResultsXML
{
    public enum BarcodeTypes
    {
        /*  Enumeration to list the barcode types available on the application
    UPC : Universal Product Code
    ITF : Interleaved 2 of 5 */
        Upc,
        Itf,
        DataMatrix,
        Ean,
        Unknown
    }
}
