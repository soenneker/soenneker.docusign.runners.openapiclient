using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Docusign.Runners.OpenApiClient.Utils.Abstract;

/// <summary>Regenerates the eSignature v2.1 client from Docusign's published Swagger specification.</summary>
public interface IFileOperationsUtil
{
    /// <summary>
    /// Downloads the specification, regenerates the client, and verifies a Release build.
    /// Set Docusign:LocalRepositoryPath to regenerate a local client repository without pushing by default.
    /// Docusign:PushChanges explicitly controls publication; Docusign:ClientGenerationUrl overrides the specification source.
    /// Throws when generation or compilation fails.
    /// </summary>
    ValueTask Process(CancellationToken cancellationToken = default);
}
