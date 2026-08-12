# Vcenter.ViJson.OpenApi.Model.CreateAgencyRequestType
The parameters of *EsxAgentManager.CreateAgency*.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgencyConfigInfo** | [**AgencyConfigInfo**](AgencyConfigInfo.md) | The configuration that describes how to deploy the agents in the created agency.  | 
**InitialGoalState** | **string** | Deprecated. No sense to create agency in other state than &lt;code&gt;enabled&lt;/code&gt;. &lt;code&gt;disabled&lt;/code&gt; is deprecated whereas &lt;code&gt;uninstalled&lt;/code&gt; is useless. The initial goal state of the agency. See *EamObjectRuntimeInfoGoalState_enum*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

