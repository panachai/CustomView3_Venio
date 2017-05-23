using System;
using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;

namespace CustomView3_Venio {
	public class CustomListViewSearchEmployee : BaseAdapter {

		Activity activity;
		List<DemoEmployeeModel> demoEmployeeList;

		public CustomListViewSearchEmployee(Activity activity, List<DemoEmployeeModel> demoEmployeeList) {
			this.activity = activity;
			this.demoEmployeeList = demoEmployeeList;
		}

		public override int Count {
			get {
				return demoEmployeeList.Count;
			}
		}

		public override Java.Lang.Object GetItem(int position) {
			return position;
		}

		public override long GetItemId(int position) {
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent) {
			View view = convertView;
			ViewHolder viewholder;

			if (view == null) {
				view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.Recyclerview_Search_Employee, parent, false);
				viewholder = new ViewHolder();

				viewholder.imvPicture = view.FindViewById<ImageView>(Resource.Id.imvEmployeePic);
				viewholder.txtFullname = view.FindViewById<TextView>(Resource.Id.txtFullname);
				viewholder.txtJobPosition = view.FindViewById<TextView>(Resource.Id.txtPosition);
				viewholder.txtEmail = view.FindViewById<TextView>(Resource.Id.txtEmail);
				viewholder.txtTel = view.FindViewById<TextView>(Resource.Id.txtTel);

				view.Tag = viewholder;

			} else {
				viewholder = (ViewHolder)view.Tag;
			}
			//viewholder.imvPicture = demoEmployeeList[position].ImvPicture;
			viewholder.txtFullname.Text = demoEmployeeList[position].TxtFullname;
			viewholder.txtJobPosition.Text = demoEmployeeList[position].TxtJobPosition;
			viewholder.txtEmail.Text = demoEmployeeList[position].TxtEmail;
			viewholder.txtTel.Text = demoEmployeeList[position].TxtTel;

			return view;
		}

		private class ViewHolder : Java.Lang.Object {
			//public ImageView imvShow;
			public ImageView imvPicture;
			public TextView txtFullname;
			public TextView txtJobPosition;
			public TextView txtEmail;
			public TextView txtTel;
		}
	}
}
