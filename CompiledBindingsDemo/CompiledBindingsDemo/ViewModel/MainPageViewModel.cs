using CompiledBindingsDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CompiledBindingsDemo.ModelView
{
	public class MainPageViewModel
	{
        public ObservableCollection<Customer> Customers { get; set; }

        public MainPageViewModel()
        {
            Customers = new ObservableCollection<Customer>
            {
                new Customer
                {
                    Name = "John",
                    Age = 32
                },
				new Customer
				{
					Name = "Jonny",
					Age = 40
				},
				new Customer
				{
					Name = "Jax",
					Age = 45
				},
				new Customer
				{
					Name = "Ermac",
					Age = 87
				},
				new Customer
				{
					Name = "Sub-zero",
					Age = 50
				},
			};
        }
    }
}
