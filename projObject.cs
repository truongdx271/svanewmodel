using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SVALib
{
	public class projObject{
		public string projectName {get;set;}
		public string projectCode {get;set;}
		public string projectOwner {get;set;}
		public List<string> projectMember {get;set;}
		public List<int> ticket {get;set;}
		public List<Scan> scans {get;set;}
		public string id {get;set;}
		
		public projObject(string projectName,string projectCode,string projectOwner,List<string> projectMember,List<int> ticket,List<Scan> scans){
		this.projectName=projectName;
		this.projectCode=projectCode;
		this.projectOwner=projectOwner;
		this.projectMember=projectMember;
		this.ticket=ticket;
		this.scans=scans;
		}
	}
}