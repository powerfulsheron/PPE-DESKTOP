using System;
using System.Collections.Generic;

namespace BelleTable.TypeStructureClass
{

    public class TypeStructure
    {
        private int codeTypeStructure;

        private string libelleTypeStructure;

        private List<Structure> lesStructure;

        public TypeStructure()
        {

        }

        /**  setter **/
        public void SetcodeTypeStructure(int uncodeTypeStructure)
        {
            codeTypeStructure = uncodeTypeStructure;
        }
        public void SetlibelleTypeStructure(string unlibelleTypeStructure)
        {
            libelleTypeStructure = unlibelleTypeStructure;
        }


        /**  getter **/
        public int GetcodeTypeStructure()
        {
            return codeTypeStructure;
        }
        public string GetlibelleTypeStructure()
        {
            return libelleTypeStructure;
        }
    }
}