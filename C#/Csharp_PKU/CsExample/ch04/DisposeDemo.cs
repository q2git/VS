using System;
using System.ComponentModel;
public class BaseResource: IDisposable  //����
{
	private IntPtr handle;  //�ⲿ��Դ
	private Component Components; //�ڲ���Դ
	private bool disposed = false; //״̬

	public BaseResource() //���췽��
	{
	}

	public void Dispose() //ʵ��IDisposable�ӿ�
	{
		Dispose(true);
		GC.SuppressFinalize(this); //��ֹ
	}

	protected virtual void Dispose(bool disposing) //�鷽����������Ը���
	{
		if(!this.disposed)
		{
			if(disposing)
			{
				Components.Dispose(); //��������Դ���ͷ�
			}
			CloseHandle(handle);  //�ⲿ��Դ���ͷ�
			handle = IntPtr.Zero;
		}
		disposed = true;         
	}

	~BaseResource()     //��������
	{
		Dispose(false);  //����Dispose()����
	}

	public void Close() //����������֣����ⲿ����
	{
		if(this.disposed)
		{
			throw new ObjectDisposedException("...");
		}
	}

	public void CloseHandle(IntPtr n)
	{
		//......
	}

}

public class MyResourceWrapper: BaseResource  //����
{
	private ManagedResource addedManaged;
	private NativeResource addedNative;
	private bool disposed = false;

	public MyResourceWrapper()
	{
	}

	protected override void Dispose(bool disposing)
	{
		if(!this.disposed)
		{
			try
			{
				if(disposing)
				{
					addedManaged.Dispose();         
				}
				CloseHandle(addedNative);
				this.disposed = true;
			}
			finally
			{
				base.Dispose(disposing);  //���ø����Dispose()����
			}
		}
	}

	public void CloseHandle(NativeResource n)
	{
		//......
	}

}

public class ManagedResource
{
	//......
	public virtual void Dispose()
	{
		//......
	}
}

public class NativeResource
{
	//......
}

public class Test
{
	static void Main()
	{
	}
}
