using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace SVALib
{
	public class ResultItem{
		public int identify {get;set;}
		public string displayTxt {get;set;}
		public string pathFile {get;set;}
		public int lineNumber{get;set;}
		public string result{get;set;}
		
		public ResultItem(int identify,string displayTxt,int pathFile,string lineNumber,string result){
		this.identify=identify;
		this.displayTxt=displayTxt;
		this.pathFile=pathFile;
		this.lineNumber=lineNumber;
		this.result=result;
		}
	}
} 


