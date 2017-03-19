using System;


namespace Maquette_Belle_Table_Final
{
    public class TypeRdv
    {
        public virtual int idTypeRdv { get; set; }
        public virtual string libelleTypeRdv { get; set; }

        public TypeRdv()
        {

        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}]", libelleTypeRdv);
        }
    }
}