// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v0/services/keyword_plan_ad_group_service.proto
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
  /// Service to manage Keyword Plan ad groups.
  /// </summary>
  public static partial class KeywordPlanAdGroupService
  {
    static readonly string __ServiceName = "google.ads.googleads.v0.services.KeywordPlanAdGroupService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.GetKeywordPlanAdGroupRequest> __Marshaller_GetKeywordPlanAdGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.GetKeywordPlanAdGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Resources.KeywordPlanAdGroup> __Marshaller_KeywordPlanAdGroup = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Resources.KeywordPlanAdGroup.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsRequest> __Marshaller_MutateKeywordPlanAdGroupsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsResponse> __Marshaller_MutateKeywordPlanAdGroupsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetKeywordPlanAdGroupRequest, global::Google.Ads.GoogleAds.V0.Resources.KeywordPlanAdGroup> __Method_GetKeywordPlanAdGroup = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetKeywordPlanAdGroupRequest, global::Google.Ads.GoogleAds.V0.Resources.KeywordPlanAdGroup>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetKeywordPlanAdGroup",
        __Marshaller_GetKeywordPlanAdGroupRequest,
        __Marshaller_KeywordPlanAdGroup);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsRequest, global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsResponse> __Method_MutateKeywordPlanAdGroups = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsRequest, global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateKeywordPlanAdGroups",
        __Marshaller_MutateKeywordPlanAdGroupsRequest,
        __Marshaller_MutateKeywordPlanAdGroupsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V0.Services.KeywordPlanAdGroupServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of KeywordPlanAdGroupService</summary>
    public abstract partial class KeywordPlanAdGroupServiceBase
    {
      /// <summary>
      /// Returns the requested Keyword Plan ad group in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Resources.KeywordPlanAdGroup> GetKeywordPlanAdGroup(global::Google.Ads.GoogleAds.V0.Services.GetKeywordPlanAdGroupRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsResponse> MutateKeywordPlanAdGroups(global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for KeywordPlanAdGroupService</summary>
    public partial class KeywordPlanAdGroupServiceClient : grpc::ClientBase<KeywordPlanAdGroupServiceClient>
    {
      /// <summary>Creates a new client for KeywordPlanAdGroupService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public KeywordPlanAdGroupServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for KeywordPlanAdGroupService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public KeywordPlanAdGroupServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected KeywordPlanAdGroupServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected KeywordPlanAdGroupServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested Keyword Plan ad group in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.KeywordPlanAdGroup GetKeywordPlanAdGroup(global::Google.Ads.GoogleAds.V0.Services.GetKeywordPlanAdGroupRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetKeywordPlanAdGroup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested Keyword Plan ad group in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.KeywordPlanAdGroup GetKeywordPlanAdGroup(global::Google.Ads.GoogleAds.V0.Services.GetKeywordPlanAdGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetKeywordPlanAdGroup, null, options, request);
      }
      /// <summary>
      /// Returns the requested Keyword Plan ad group in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.KeywordPlanAdGroup> GetKeywordPlanAdGroupAsync(global::Google.Ads.GoogleAds.V0.Services.GetKeywordPlanAdGroupRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetKeywordPlanAdGroupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested Keyword Plan ad group in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.KeywordPlanAdGroup> GetKeywordPlanAdGroupAsync(global::Google.Ads.GoogleAds.V0.Services.GetKeywordPlanAdGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetKeywordPlanAdGroup, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsResponse MutateKeywordPlanAdGroups(global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MutateKeywordPlanAdGroups(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsResponse MutateKeywordPlanAdGroups(global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateKeywordPlanAdGroups, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsResponse> MutateKeywordPlanAdGroupsAsync(global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MutateKeywordPlanAdGroupsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsResponse> MutateKeywordPlanAdGroupsAsync(global::Google.Ads.GoogleAds.V0.Services.MutateKeywordPlanAdGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateKeywordPlanAdGroups, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override KeywordPlanAdGroupServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new KeywordPlanAdGroupServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(KeywordPlanAdGroupServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetKeywordPlanAdGroup, serviceImpl.GetKeywordPlanAdGroup)
          .AddMethod(__Method_MutateKeywordPlanAdGroups, serviceImpl.MutateKeywordPlanAdGroups).Build();
    }

  }
}
#endregion
