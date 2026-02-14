#include <iostream>
   #include <string>
   using namespace std;
   
   void check (string first, string last, string pw) {
   string credentials;
   credentials = first + last + pw;
   
   if (credentials == "RowellMarquinapogi") {
   cout << "Welcome, Sir Well!";
   }

   else if (credentials == "ClyzaGananiloveNolan"){
   cout << "Welcome, Mam Clyza!";
   }

   else if (credentials == "Rafael AntonioDeePogisiSir"){
   cout << "Welcome, Master!";
   }

  else {
  cout << "Sino ka?";
  }
  } 

   int main(){
   string fname, lname, password;

   cout << "Enter First Name: ";
   getline (cin,fname);

   cout << "Enter Last Name: ";
  getline (cin,lname);

   cout << "Enter Password: ";
   getline (cin,password);

   check(fname,lname,password); 
 

   }