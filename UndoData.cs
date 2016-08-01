using System;

namespace databasesystems
{
	public class UndoData
	{
		private string buf;
		private string columns;
		private string _select;
		private string _from;

		public UndoData ()
		{
			buf = "";
			columns = "";
			_select = "";
			_from = "";
		}

		public UndoData (string _buf)
		{
			buf = _buf;
			columns = "RETURNS TABLE(";
			_select = "SELECT ";
			_from = "FROM ";
		}

		public UndoData (string _buf,string _columns, string __select, string __from)
		{
			buf = _buf;
			columns = _columns;
			_select = __select;
			_from = __from;
		}

		public string Buf
		{
			get { return buf; }
	        set { buf = value; }
		}

		public string Col
		{
			get { return columns; }
			set {  columns = value; }
		}

		public string Sel
		{
			get { return _select; }
	        set { _select = value; }
		}

		public string Fro
		{
			get { return _from; }
	        set { _from = value; }
		}
	}
}

