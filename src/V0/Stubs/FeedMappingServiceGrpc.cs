// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v0/services/feed_mapping_service.proto
// Original file comments:
// Copyright 2018 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V0.Services {
  /// <summary>
  /// Service to manage feed mappings.
  /// </summary>
  public static partial class FeedMappingService
  {
    static readonly string __ServiceName = "google.ads.googleads.v0.services.FeedMappingService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.GetFeedMappingRequest> __Marshaller_GetFeedMappingRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.GetFeedMappingRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Resources.FeedMapping> __Marshaller_FeedMapping = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Resources.FeedMapping.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsRequest> __Marshaller_MutateFeedMappingsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsResponse> __Marshaller_MutateFeedMappingsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetFeedMappingRequest, global::Google.Ads.GoogleAds.V0.Resources.FeedMapping> __Method_GetFeedMapping = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetFeedMappingRequest, global::Google.Ads.GoogleAds.V0.Resources.FeedMapping>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFeedMapping",
        __Marshaller_GetFeedMappingRequest,
        __Marshaller_FeedMapping);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsRequest, global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsResponse> __Method_MutateFeedMappings = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsRequest, global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateFeedMappings",
        __Marshaller_MutateFeedMappingsRequest,
        __Marshaller_MutateFeedMappingsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V0.Services.FeedMappingServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FeedMappingService</summary>
    public abstract partial class FeedMappingServiceBase
    {
      /// <summary>
      /// Returns the requested feed mapping in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Resources.FeedMapping> GetFeedMapping(global::Google.Ads.GoogleAds.V0.Services.GetFeedMappingRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates or removes feed mappings. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsResponse> MutateFeedMappings(global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FeedMappingService</summary>
    public partial class FeedMappingServiceClient : grpc::ClientBase<FeedMappingServiceClient>
    {
      /// <summary>Creates a new client for FeedMappingService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public FeedMappingServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FeedMappingService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public FeedMappingServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected FeedMappingServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected FeedMappingServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested feed mapping in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.FeedMapping GetFeedMapping(global::Google.Ads.GoogleAds.V0.Services.GetFeedMappingRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFeedMapping(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested feed mapping in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.FeedMapping GetFeedMapping(global::Google.Ads.GoogleAds.V0.Services.GetFeedMappingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFeedMapping, null, options, request);
      }
      /// <summary>
      /// Returns the requested feed mapping in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.FeedMapping> GetFeedMappingAsync(global::Google.Ads.GoogleAds.V0.Services.GetFeedMappingRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFeedMappingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested feed mapping in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.FeedMapping> GetFeedMappingAsync(global::Google.Ads.GoogleAds.V0.Services.GetFeedMappingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFeedMapping, null, options, request);
      }
      /// <summary>
      /// Creates or removes feed mappings. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsResponse MutateFeedMappings(global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MutateFeedMappings(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes feed mappings. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsResponse MutateFeedMappings(global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateFeedMappings, null, options, request);
      }
      /// <summary>
      /// Creates or removes feed mappings. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsResponse> MutateFeedMappingsAsync(global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MutateFeedMappingsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes feed mappings. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsResponse> MutateFeedMappingsAsync(global::Google.Ads.GoogleAds.V0.Services.MutateFeedMappingsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateFeedMappings, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override FeedMappingServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FeedMappingServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(FeedMappingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetFeedMapping, serviceImpl.GetFeedMapping)
          .AddMethod(__Method_MutateFeedMappings, serviceImpl.MutateFeedMappings).Build();
    }

  }
}
#endregion
