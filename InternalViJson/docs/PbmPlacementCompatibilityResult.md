# Vcenter.ViJson.OpenApi.Model.PbmPlacementCompatibilityResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hub** | [**PbmPlacementHub**](PbmPlacementHub.md) | The &lt;code&gt;Datastore&lt;/code&gt; or &lt;code&gt;StoragePod&lt;/code&gt; under consideration as a location for virtual machine files.  | 
**HubInfo** | [**PbmPlacementHubInfo**](PbmPlacementHubInfo.md) | Additional information about *PbmPlacementCompatibilityResult.hub*  | [optional] 
**MatchingResources** | [**List&lt;PbmPlacementMatchingResources&gt;**](PbmPlacementMatchingResources.md) | Resources that match the policy.  If populated, signifies that there are specific resources that match the policy for *PbmPlacementCompatibilityResult.hub*. If null, signifies that all resources (for example, hosts connected to the datastore or storage pod) are compatible.  | [optional] 
**HowMany** | **long** | How many objects of the kind requested can be provisioned on this *PbmPlacementCompatibilityResult.hub*.  | [optional] 
**Utilization** | [**List&lt;PbmPlacementResourceUtilization&gt;**](PbmPlacementResourceUtilization.md) | This field is not populated if there is no size in the query, i.e.  if the request carries only policy and no size requirements, this will not be populated.  | [optional] 
**Warning** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Array of faults that describe issues that may affect profile compatibility.  Users should consider these issues before using this &lt;code&gt;Datastore&lt;/code&gt; or &lt;code&gt;StoragePod&lt;/code&gt; and a connected &lt;code&gt;Host&lt;/code&gt;s.  | [optional] 
**Error** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Array of faults that prevent this datastore or storage pod from being compatible with the specified profile, including if no host connected to this *PbmPlacementCompatibilityResult.hub* is compatible.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

