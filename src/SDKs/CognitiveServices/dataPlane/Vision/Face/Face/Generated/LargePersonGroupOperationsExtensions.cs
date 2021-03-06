// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LargePersonGroupOperations.
    /// </summary>
    public static partial class LargePersonGroupOperationsExtensions
    {
            /// <summary>
            /// Create a new large person group with specified largePersonGroupId, name and
            /// user-provided userData.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='largePersonGroupId'>
            /// Id referencing a particular large person group.
            /// </param>
            /// <param name='name'>
            /// User defined name, maximum length is 128.
            /// </param>
            /// <param name='userData'>
            /// User specified data. Length should not exceed 16KB.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateAsync(this ILargePersonGroupOperations operations, string largePersonGroupId, string name = default(string), string userData = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CreateWithHttpMessagesAsync(largePersonGroupId, name, userData, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete an existing large person group. Persisted face features of all
            /// people in the large person group will also be deleted.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='largePersonGroupId'>
            /// Id referencing a particular large person group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ILargePersonGroupOperations operations, string largePersonGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(largePersonGroupId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve the information of a large person group, including its name and
            /// userData.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='largePersonGroupId'>
            /// Id referencing a particular large person group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LargePersonGroup> GetAsync(this ILargePersonGroupOperations operations, string largePersonGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(largePersonGroupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an existing large person group's display name and userData. The
            /// properties which does not appear in request body will not be updated.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='largePersonGroupId'>
            /// Id referencing a particular large person group.
            /// </param>
            /// <param name='name'>
            /// User defined name, maximum length is 128.
            /// </param>
            /// <param name='userData'>
            /// User specified data. Length should not exceed 16KB.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this ILargePersonGroupOperations operations, string largePersonGroupId, string name = default(string), string userData = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(largePersonGroupId, name, userData, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve the training status of a large person group (completed or
            /// ongoing).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='largePersonGroupId'>
            /// Id referencing a particular large person group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrainingStatus> GetTrainingStatusAsync(this ILargePersonGroupOperations operations, string largePersonGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTrainingStatusWithHttpMessagesAsync(largePersonGroupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List large person groups and their information.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='start'>
            /// List large person groups from the least largePersonGroupId greater than the
            /// "start".
            /// </param>
            /// <param name='top'>
            /// The number of large person groups to list.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LargePersonGroup>> ListAsync(this ILargePersonGroupOperations operations, string start = default(string), int? top = 1000, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(start, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Queue a large person group training task, the training task may not be
            /// started immediately.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='largePersonGroupId'>
            /// Id referencing a particular large person group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task TrainAsync(this ILargePersonGroupOperations operations, string largePersonGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.TrainWithHttpMessagesAsync(largePersonGroupId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
