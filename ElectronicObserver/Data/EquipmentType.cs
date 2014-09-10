﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicObserver.Data {

	/// <summary>
	/// 装備の種別
	/// </summary>
	public class EquipmentType : ResponseWrapper, IIdentifiable {

		/// <summary>
		/// 装備の種別
		/// </summary>
		public int TypeID {
			get { return RawData.api_id; }
		}

		/// <summary>
		/// 名前
		/// </summary>
		public string Name {
			get { return RawData.api_name; }
		}

		//show_flg


		public int ID {
			get { return TypeID; }
		}


	}


}
