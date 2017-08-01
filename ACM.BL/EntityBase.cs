namespace ACM.BL
{
	public enum EntityStateOption
	{
		Active,
		Deleted
	}

	public abstract class EntityBase
	{
		public EntityStateOption EntityStateOption { get; set; }
		public bool HasChanges { get; set; }
		public bool IsNew { get; private set; }

		public bool IsValid
		{
			get { return Validate(); }
		}

		public abstract bool Validate();

	}
}
