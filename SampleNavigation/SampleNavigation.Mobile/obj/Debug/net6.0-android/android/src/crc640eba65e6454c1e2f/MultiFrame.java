package crc640eba65e6454c1e2f;


public class MultiFrame
	extends crc6499cc3f8d6dc23bc6.Grid
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Chinook.SectionsNavigation.MultiFrame, Chinook.SectionsNavigation.Uno.WinUI", MultiFrame.class, __md_methods);
	}


	public MultiFrame (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MultiFrame.class)
			mono.android.TypeManager.Activate ("Chinook.SectionsNavigation.MultiFrame, Chinook.SectionsNavigation.Uno.WinUI", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
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
