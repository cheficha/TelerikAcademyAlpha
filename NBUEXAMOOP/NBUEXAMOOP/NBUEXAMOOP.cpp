/***
FN:F00000
PID:1
GID:1
*/
#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <iomanip>
#include <algorithm>
#include <boost/algorithm/string.hpp>


using namespace std;

class Person
{
protected:
	string name;
	string familyName;
public:
	string getName() {
		return Person::name;
	};
	string getFamilyName() {
		return  Person::familyName;
	};
	void setName(string n) {
		Person::name = n;
	};
	void setFamilyName(string f) {

		Person::familyName = f;
	};
	void Read(fstream* streamForReading)
	{
	};
	void  Write(fstream* streamForWriting)
	{
	};
	Person()
	{

	}
	~Person() {};
};
class Student :public Person
{
private:
	string fNumber;
public:
	Student() {};
	~Student() {};
	string getFnumber()
	{
		return Student::fNumber;
	};
	void setFnumber(string num)
	{
		name = num;
	};
	void Read(fstream& streamForReading)
	{
		string line;
		vector<string> results;
		getline(streamForReading, line,' ');
		boost::split(results, line, [](char c) {return c == ' '; });
		setName(results[0]);
		setFamilyName(results[1]);
		setFnumber(results[2]);

	};
	void  Write(fstream* streamForWriting)
	{
	};

};

ostream & operator << (ostream &os, Person *p);
istream & operator >> (istream &is, Person *p);

//compare functioin, DO NOT CHANGE OR REMOVE
bool comp(Person *a, Person *b)
{
	return *a < *b;
}

int main(int argc, char * argv[])
{


	vector<Person *> people;



	/*read the people from the files using the stream operator >>, for example, if 'in' is an input stream:*/
	Person *p = new Person();
	while (in >> p)
	{
		people.push_back(p);
		p = new Person();
	}
	delete p;

	sort(people.begin(), people.end(), comp); //DO NOT CHANGE OR REMOVE THIS CODE

											  //code your output here

	return 0;
}


