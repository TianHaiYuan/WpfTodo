using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTodo.Common;

namespace WpfTodo.ViewModels
{
    public class MainViewModel
    {
		public MainViewModel()
		{
            MenuItems=new ObservableCollection<MenuItem>();
			MenuItems.Add(new MenuItem() { Icon= "\xe635", Name= "我的一天", Count=1});
			MenuItems.Add(new MenuItem() { Icon= "\xe6b6", Name="重要",Count=1});
			MenuItems.Add(new MenuItem() { Icon= "\xe6e1", Name= "已计划日程", Count=1});
			MenuItems.Add(new MenuItem() { Icon= "\xe614", Name= "已分配给你", Count=1});
			MenuItems.Add(new MenuItem() { Icon= "\xe755", Name="任务",Count=1});

        }
		private ObservableCollection<MenuItem> menuItems;

		public ObservableCollection<MenuItem> MenuItems
        {
			get { return menuItems; }
			set { menuItems = value; }
		}

	}
}
