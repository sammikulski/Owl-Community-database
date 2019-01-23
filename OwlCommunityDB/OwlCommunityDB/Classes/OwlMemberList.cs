/*Project 4 - Final Project - Owl Community Database
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This OwlMemberList class keeps track of all owlmembers that we have
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OwlCommunityDB.Models;

namespace OwlCommunityDB.Classes
{
    [Serializable()]
    public class OwlMemberList
    {
       private List<OwlMember> memberList;
       OwlMember lookedUpUser;

        // Parameterless Constructor
        public OwlMemberList()
        {
            memberList = new List<OwlMember>();
        }

        // Returns number of members in the member list
        public int Count()
        {
            return memberList.Count();
        }

        // Adds member to list
        public void addToList(OwlMember member)
        {
            memberList.Add(member);
        }

        // Removes member from list
        public void removeFromList(OwlMember member)
        {
            memberList.Remove(member);
        }
        //returns owlMember at a given index
        public OwlMember getItem(int index)
        {
            return memberList[index];
        }

        //empties the list
        public void Empty()
        {
            memberList.Clear();
        }

        // Searches for OwlMember in the list
        public OwlMember searchList(int memberID, ref bool searchSuccessful)
        {
            searchSuccessful = false;
            foreach (OwlMember member in memberList)
            {
                if (member.owlID == memberID)
                {
                    lookedUpUser = member;
                    searchSuccessful = true;
                    break;
                }
                else
                {
                    lookedUpUser = null;
                    searchSuccessful = false;
                }
            }
            return lookedUpUser;
        }
        //displays the list in a string format
        public string displayList()
        {
            string display = "";
            foreach (OwlMember member in memberList)
            {
                display += member.ToString();
            }
            return display;
        }

        //overrided to string function that returns a representation of the list
        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < memberList.Count(); i++)
            {
                s += memberList[i].ToString();
                s += "\n----------------------------------------------------\n";
            }

            return s;
        }
    }
}
