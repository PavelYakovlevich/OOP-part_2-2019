///////////////////////////////////////////////////////////
//  User.cs
//  Implementation of the Class User
//  Generated by Enterprise Architect
//  Created on:      10-���-2019 0:12:31
//  Original author: Mi Pro
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Class;
namespace Class {
	public class User {

		private Basket basket;
		private int id;
		private int id_role;
		private string login;
		private string name;
		private string password;
		private string role;
		private string surname;
		public Class Model m_Order;

		public User(){

		}

		~User(){

		}

		/// 
		/// <param name="id"></param>
		public void addGood(int id){

		}

		/// 
		/// <param name="id"></param>
		public bool closeOrder(int id){

			return false;
		}

		/// 
		/// <param name="criteria"></param>
		public Object findGood(string criteria){

			return null;
		}

		/// 
		/// <param name="basket"></param>
		public int openOrder(Basket basket){

			return 0;
		}

		/// 
		/// <param name="id"></param>
		public Object showGoodInfo(int id){

			return null;
		}

		public void sign_out(){

		}

		public void viewBasket(){

		}

		public void viewCatalog(){

		}

	}//end User

}//end namespace Class