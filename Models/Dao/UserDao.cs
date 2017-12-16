using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
	public class UserDao
	{
		BITCON_TLCN_DBContext db = null;
		
		// contrucstor
		public UserDao()
		{
			db = new BITCON_TLCN_DBContext();
		}

		public USER selectUserbyId(int id)
		{
			return db.USERs.SingleOrDefault(x=>x.Id_user == id);
		}
		
	}
}
