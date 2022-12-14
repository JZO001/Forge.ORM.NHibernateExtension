/* *********************************************************************
 * Date: 25 Apr 2012
 * Created by: Zoltan Juhasz
 * E-Mail: forge@jzo.hu
***********************************************************************/

using System;
using System.Runtime.Serialization;

namespace Forge.ORM.NHibernateExtension
{

    /// <summary>
    /// Exception for entity refresh fail scenario
    /// </summary>
    [Serializable]
    public class EntityRefreshException : ORMException
    {

        #region Constructor(s)

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRefreshException"/> class.
        /// </summary>
        public EntityRefreshException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRefreshException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public EntityRefreshException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRefreshException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        public EntityRefreshException(string message, Exception ex)
            : base(message, ex)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRefreshException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info"/> parameter is null. </exception>
        ///   
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult"/> is zero (0). </exception>
        protected EntityRefreshException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion

    }

}
