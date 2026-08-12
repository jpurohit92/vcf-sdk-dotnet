# Vcenter.ViJson.OpenApi.Model.HostMultipathInfoPath

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Identifier of the path.  | 
**Name** | **string** | Name of path.  Use this name to configure LogicalUnit multipathing policy using *HostStorageSystem.EnableMultipathPath* and *HostStorageSystem.DisableMultipathPath*.  | 
**PathState** | **string** | Deprecated as of VI API 4.0: - System reported path states are available in *HostMultipathInfoPath.state*. - Paths slated for I/O can be found using *HostMultipathInfoPath.isWorkingPath*.  State of the path.  Must be one of the values of *MultipathState_enum* &lt;dl&gt; &lt;dt&gt;active&lt;/dt&gt; &lt;dd&gt;Path can be used for I/O and is currently a working path.&lt;/dd&gt; &lt;dt&gt;standby&lt;/dt&gt; &lt;dd&gt;Path can be used for I/O but is not a working path or can be used if active paths fail.&lt;/dd&gt; &lt;dt&gt;disabled&lt;/dt&gt; &lt;dd&gt;Path has been administratively disabled.&lt;/dd&gt; &lt;dt&gt;dead&lt;/dt&gt; &lt;dd&gt;Path cannot be used for I/O.&lt;/dd&gt; &lt;dt&gt;unknown&lt;/dt&gt; &lt;dd&gt;Path is in unknown error state.&lt;/dd&gt; &lt;/dl&gt;  | 
**State** | **string** | System-reported state of the path.  Must be one of the values of *MultipathState_enum* &lt;dl&gt; &lt;dt&gt;active&lt;/dt&gt; &lt;dd&gt;Path can be used for I/O.&lt;/dd&gt; &lt;dt&gt;standby&lt;/dt&gt; &lt;dd&gt;Path can be used for I/O if active paths fail.&lt;/dd&gt; &lt;dt&gt;disabled&lt;/dt&gt; &lt;dd&gt;Path has been administratively disabled.&lt;/dd&gt; &lt;dt&gt;dead&lt;/dt&gt; &lt;dd&gt;Path cannot be used for I/O.&lt;/dd&gt; &lt;dt&gt;unknown&lt;/dt&gt; &lt;dd&gt;Path is in unknown error state.&lt;/dd&gt; &lt;/dl&gt;  | [optional] 
**IsWorkingPath** | **bool** | A path, managed by a given path selection policy(psp) plugin, is denoted to be a Working Path if the psp plugin is likely to select the path for performing I/O in the near future.  | [optional] 
**Adapter** | **string** | The host bus adapter at one endpoint of this path.  | 
**Lun** | **string** | The logical unit at one endpoint of this path.  | 
**Transport** | [**HostTargetTransport**](HostTargetTransport.md) | Transport information for the target end of the path.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

