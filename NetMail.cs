using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using Org.BouncyCastle;

namespace DinkySpork {

public class NetMail {

       public string encrypt(string plaintext)
       {
       string cyphertext = "";
       return cyphertext;
       }

/*
       public List<string> dbStuff()
       {
       List<string> elle = new List<string>();
       	      System.Data.SQLiteConnection m_dbConnection = new
	     		    SQLiteConnection("Data Source=email.db;Version=3;");
	      m_dbConnection.Open();
	      string sql = "SELECT * FROM EmailAddress";
	      SQLiteConnection command = new
	      		    SQLiteConnection(sql, mdbConnection);
	SQLiteDataReader reader = command.ExecuteReader();
	while (reader.Read()) elle.Add(reader["EmailAddress"]);
	return elle;
	}
*/	    
      public static void Main(string[] args){
      	    MailMessage message = new MailMessage();
            string FromAddress = args[0];
	    string password = args[1];
	    message.From = new MailAddress(FromAddress);

	    List<string> l = new List<string>();
	    Console.WriteLine("To: ");
	    /*
	    foreach (string s in l ){
	    	    Console.Write(s + "   ");
	    }
	    */
	    string to = Console.ReadLine();
	    to = "";
	    message.To.Add(to);
	    Console.Write("Subj: ");
	    
	    message.Subject = Console.ReadLine();
	    /*
	    message.To.Add(args[2]);
	    message.Subject = args[3];
	    */
	    
	    string body = "testing testing 1 2 3"; // System.IO.File.ReadAllText(@args[4]);
            message.Body = body;

	    string user = FromAddress;
	    SmtpClient server = new SmtpClient();
	    server.Host = "smtp.gmail.com";
	    server.Port = 587;
	    server.UseDefaultCredentials = false;
	    server.EnableSsl = true;

	    server.Credentials = new NetworkCredential(user, password);
/*
	    try {
	    	server.Send(message);
	Console.WriteLine("Success!");
		}
		catch (SmtpFailedRecipientException err)
		{
	Console.WriteLine("\n\n"+err.Message+"\n\n"+err.FailedRecipient);
		}
	*/
      }
}

}