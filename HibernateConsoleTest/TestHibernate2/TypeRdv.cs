﻿using System;


namespace PamNHibernateDemos
{
    public class TypeRdv
    {
        public virtual int idTypeRdv { get; set; }
        public virtual string typeRdv { get; set; }

        public TypeRdv()
        {

        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}]", typeRdv);
        }
    }
}