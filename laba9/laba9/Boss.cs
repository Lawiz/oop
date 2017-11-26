using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
	class Boss
	{
		public delegate void CheckerU();

		public event CheckerU Turn_on, UpgradeEvent;

		public string name { get; set; }
		public bool upgrade = false;
		private int workU = 124;


		public int U = 0;
		public void On()
		{
			U = workU;
			Turn_on();

		}
		public void Off()
		{
			U = 0;
		}
		public void Upgrade()
		{

			upgrade = true;
			UpgradeEvent();

		}
      

		

            
                
    }
}
