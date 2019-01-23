/*Project 4 - Final Project - Owl Community Database
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This serializable file class was not used in part II of the project,
* but this is used to write the owl member objects to a file
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
// To read and write files
using System.IO;
// To serialize a persistant object
using System.Runtime.Serialization.Formatters.Binary;

namespace OwlCommunityDB.Classes
{
    public static class SerializableFile
    {
        // This class manages a serializable file object by reading from and writing to a file

        // Write the Person List to file as a serialized binary object
        public static bool writeToFile(OwlMemberList plist, string fn)
        {
            Stream thisFileStream;
            BinaryFormatter serializer = new BinaryFormatter();

            if (plist.Count() > 0)
            {
                try
                {
                    thisFileStream = File.Create(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error: Owl Member List not written", "SFManager File Open");
                    MessageBox.Show(ex.ToString());
                    return false;
                }  // end Try

                try
                {
                    serializer.Serialize(thisFileStream, plist);
                    MessageBox.Show("File write: Owl Member List was written to serializable file.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File write error: Owl Member List not written", "SFManager File Write");
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                finally
                {
                    thisFileStream.Close();
                }  // end Try
            }
            else
                MessageBox.Show("No Owl Member in List");
            // end if

            return true;  // The file write succeeded

        }  // end WriteToFile


        // Read the Person List from file as a serialized binary object
        public static bool readFromFile(ref OwlMemberList plist, string fn)
        {
            Stream TestFileStream;
            BinaryFormatter deserializer = new BinaryFormatter();

            if (File.Exists(fn))
            {
                try
                {
                    TestFileStream = File.OpenRead(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error: Open with new Owl Member List", "SFManager, File Open");
                    plist = new Classes.OwlMemberList();
                    return false;
                }  // end Try

                try
                {
                    plist = (OwlMemberList)deserializer.Deserialize(TestFileStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File read error: Open with new Owl Member List", "SFManager File Read");
                    plist = new Classes.OwlMemberList();
                    return false;
                }
                finally
                {
                    TestFileStream.Close();
                }  // end Try
            }  // end then part of if
            else
            {
                MessageBox.Show("File does not exist: Open with new Owl Member List", "SF Manager Exists ");
                plist = new Classes.OwlMemberList();
            }  // end if

            return true;   // The file read succeeded

        }  // end readFromFile 

    }  // end SFManager Class
}
