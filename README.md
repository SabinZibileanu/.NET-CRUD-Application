#La proiect au lucrat:Zibileanu Sabin,student in anul 2,grupa 4 si Budeanu Andreea,studenta in anul 2,grupa 2

#Budeanu Andreea s-a ocupat de tot ceea ce tine de design,respectiv fisiere cshtml,si anume (Login.cshtml,Inregistrare.cshtml,Logout.cshtml)iar eu(Zibileanu Sabin) m-am ocupat de lucrul cu bazele de date,de implementarea autentificarii(cu posibilitatea de remember me),inregistrarii pe pagina si autorizarea pe fiecare pagina,de lucrul cu bazele de date si de creearea legaturii intre server si baza de date

#Pentru a folosi operatiile de creare,actualizare,stergere am creeat o baza de date auxiliara numita BDStudents in care am stocat numele,anul si grupa din care face parte fiecare student,cu validari implementate la operatia de creare.Am construit baza de date BDStudents folosind SSMS.

#La momentul inregistrarii unui utilizator,detaliile despre acesta preluate la inregistrare sunt stocate in baza de date numita BDProiect,care poate fi vazuta de catre utilizator la momentul logarii pe site,sub forma unei liste paginate cu numele utilizatorilor care poate fi sortata dupa username si de asemenea se poate cauta un utilizator cu un search box.

#Autorizarile au fost implementate pe fiecare pagina,astfel daca utilizatorul care nu este inca logat sau nu are cont pe site incearca sa intre sa vada pagina utilizatorilor,acesta va fi redirectionat catre pagina de login.De asemenea utilizatorul care se va loga pe site va stii ca este logat,butonul de logout fiind prezentat ca Logout(nume user).

#Am lucrat cu .NET 5.0
