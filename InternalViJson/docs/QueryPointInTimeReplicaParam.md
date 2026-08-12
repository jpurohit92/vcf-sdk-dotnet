# Vcenter.ViJson.OpenApi.Model.QueryPointInTimeReplicaParam

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReplicaTimeQueryParam** | [**ReplicaQueryIntervalParam**](ReplicaQueryIntervalParam.md) | Specifies the replica time span that vSphere is interested in.  | [optional] 
**PitName** | **string** | Only the replicas that match the given name are requested.  A regexp according to http://www.w3.org/TR/xmlschema-2/#regexs.  | [optional] 
**Tags** | **List&lt;string&gt;** | Only the replicas with tags that match the given tag(s) are requested.  Each entry may be a regexp according to http://www.w3.org/TR/xmlschema-2/#regexs.  | [optional] 
**PreferDetails** | **bool** | This field is hint for the preferred type of return results.  It can be either true for *QueryPointInTimeReplicaSuccessResult* or false for *QueryPointInTimeReplicaSummaryResult*. If not set, VP may choose the appropriate type, as described in &lt;code&gt;ReplicaQueryIntervalParam&lt;/code&gt;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

