using System.IO;
using Microsoft.Extensions.Configuration;

namespace Frozzare.Dotenv
{
    /// <summary>
    /// A Dotenv file based <see cref="FileConfigurationProvider"/>.
    /// </summary>
    public class DotenvConfigurationProvider : FileConfigurationProvider
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public DotenvConfigurationProvider(DotenvConfigurationSource source) : base(source) { }

        /// <summary>
        /// Loads the dotenv variables.
        /// </summary>
        public override void Load(Stream stream)
        {
            Data = Dotenv.Load(stream).GetVariables();
        }
    }
}