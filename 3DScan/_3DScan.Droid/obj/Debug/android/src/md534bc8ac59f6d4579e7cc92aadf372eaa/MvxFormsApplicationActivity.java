package md534bc8ac59f6d4579e7cc92aadf372eaa;


public class MvxFormsApplicationActivity
	extends md5b60ffeb829f638581ab2bb9b1a7f4f3f.FormsApplicationActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("_3DScan.Droid.MvxFormsApplicationActivity, 3DScan.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MvxFormsApplicationActivity.class, __md_methods);
	}


	public MvxFormsApplicationActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxFormsApplicationActivity.class)
			mono.android.TypeManager.Activate ("_3DScan.Droid.MvxFormsApplicationActivity, 3DScan.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
