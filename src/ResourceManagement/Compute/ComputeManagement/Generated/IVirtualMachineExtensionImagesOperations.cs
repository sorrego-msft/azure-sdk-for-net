namespace Microsoft.Azure.Management.Compute
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq;
    using System.Linq.Expressions;
    using Microsoft.Azure.OData;
    using Microsoft.Azure;
    using Models;

    /// <summary>
    /// </summary>
    public partial interface IVirtualMachineExtensionImagesOperations
    {
        /// <summary>
        /// Gets a virtual machine extension image.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='publisherName'>
        /// </param>
        /// <param name='type'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualMachineExtensionImage>> GetWithHttpMessagesAsync(string location, string publisherName, string type, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of virtual machine extension image versions.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='publisherName'>
        /// </param>
        /// <param name='type'>
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='top'>
        /// </param>
        /// <param name='orderby'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IList<VirtualMachineImageResource>>> ListVersionsWithHttpMessagesAsync(string location, string publisherName, string type, Expression<Func<VirtualMachineImageResource, bool>> filter = default(Expression<Func<VirtualMachineImageResource, bool>>), int? top = default(int?), string orderby = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of virtual machine extension image types.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='publisherName'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IList<VirtualMachineImageResource>>> ListTypesWithHttpMessagesAsync(string location, string publisherName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
