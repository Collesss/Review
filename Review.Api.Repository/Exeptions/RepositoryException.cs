﻿namespace Review.Api.Repository.Exeptions
{
    public class RepositoryException : Exception
    {
        public RepositoryException(string message) : base(message) { }

        public RepositoryException(string message, Exception innerException) : base(message, innerException) { }
    }
}
