package crc64ddb25a1c6259c8eb;


public class Shell
	extends crc6499cc3f8d6dc23bc6.UserControl
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("SampleNavigation.Shell, SampleNavigation", Shell.class, __md_methods);
	}


	public Shell (android.content.Context p0)
	{
		super (p0);
		if (getClass () == Shell.class)
			mono.android.TypeManager.Activate ("SampleNavigation.Shell, SampleNavigation", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
