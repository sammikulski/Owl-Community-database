/*Project 4 - Final Project - Owl Community Database
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This GlobalData class keeps track of all instances of a class or form needed to
* be used throughout the entire program
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OwlCommunityDB.Controllers;

namespace OwlCommunityDB.Classes
{
    public class GlobalData
    {
        public static frmMainForm ff = new frmMainForm();
        public static OwlMemberList owlList = new OwlMemberList();
        public static Database database = new Database();

    }
}
