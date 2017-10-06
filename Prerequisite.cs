using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GURPS_Creator {

    class Prerequisite {

        public bool Has { get; set; }
        public PrerequisiteType Type { get; set; }
        public string Value { get; set; }
    }

    class PrerequisiteType {

    }
}
