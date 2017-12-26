using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace SVALib
{
	public class Scan{
		public int No {get;set;}
		public DateTime scantime {get;set;}
		public int total {get;set;}
		public List<resultItem> resultItems{get;set;}
	}
	public ResultItem(int No,DateTime scantime,int total,List<resultItem> resultItems){
		this.No=No;
		this.scantime=scantime;
		this.total=total;
		this.resultItems=resultItems;
	}
} 


