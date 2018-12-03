// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v0/services/customer_feed_service.proto
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
  /// Service to manage customer feeds.
  /// </summary>
  public static partial class CustomerFeedService
  {
    static readonly string __ServiceName = "google.ads.googleads.v0.services.CustomerFeedService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.GetCustomerFeedRequest> __Marshaller_GetCustomerFeedRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.GetCustomerFeedRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Resources.CustomerFeed> __Marshaller_CustomerFeed = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Resources.CustomerFeed.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsRequest> __Marshaller_MutateCustomerFeedsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsResponse> __Marshaller_MutateCustomerFeedsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetCustomerFeedRequest, global::Google.Ads.GoogleAds.V0.Resources.CustomerFeed> __Method_GetCustomerFeed = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetCustomerFeedRequest, global::Google.Ads.GoogleAds.V0.Resources.CustomerFeed>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerFeed",
        __Marshaller_GetCustomerFeedRequest,
        __Marshaller_CustomerFeed);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsRequest, global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsResponse> __Method_MutateCustomerFeeds = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsRequest, global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateCustomerFeeds",
        __Marshaller_MutateCustomerFeedsRequest,
        __Marshaller_MutateCustomerFeedsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V0.Services.CustomerFeedServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CustomerFeedService</summary>
    public abstract partial class CustomerFeedServiceBase
    {
      /// <summary>
      /// Returns the requested customer feed in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Resources.CustomerFeed> GetCustomerFeed(global::Google.Ads.GoogleAds.V0.Services.GetCustomerFeedRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes customer feeds. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsResponse> MutateCustomerFeeds(global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CustomerFeedService</summary>
    public partial class CustomerFeedServiceClient : grpc::ClientBase<CustomerFeedServiceClient>
    {
      /// <summary>Creates a new client for CustomerFeedService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CustomerFeedServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CustomerFeedService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CustomerFeedServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CustomerFeedServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CustomerFeedServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested customer feed in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.CustomerFeed GetCustomerFeed(global::Google.Ads.GoogleAds.V0.Services.GetCustomerFeedRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetCustomerFeed(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested customer feed in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.CustomerFeed GetCustomerFeed(global::Google.Ads.GoogleAds.V0.Services.GetCustomerFeedRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCustomerFeed, null, options, request);
      }
      /// <summary>
      /// Returns the requested customer feed in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.CustomerFeed> GetCustomerFeedAsync(global::Google.Ads.GoogleAds.V0.Services.GetCustomerFeedRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetCustomerFeedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested customer feed in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.CustomerFeed> GetCustomerFeedAsync(global::Google.Ads.GoogleAds.V0.Services.GetCustomerFeedRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCustomerFeed, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes customer feeds. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsResponse MutateCustomerFeeds(global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MutateCustomerFeeds(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes customer feeds. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsResponse MutateCustomerFeeds(global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateCustomerFeeds, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes customer feeds. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsResponse> MutateCustomerFeedsAsync(global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MutateCustomerFeedsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes customer feeds. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsResponse> MutateCustomerFeedsAsync(global::Google.Ads.GoogleAds.V0.Services.MutateCustomerFeedsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateCustomerFeeds, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CustomerFeedServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CustomerFeedServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CustomerFeedServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCustomerFeed, serviceImpl.GetCustomerFeed)
          .AddMethod(__Method_MutateCustomerFeeds, serviceImpl.MutateCustomerFeeds).Build();
    }

  }
}
#endregion
