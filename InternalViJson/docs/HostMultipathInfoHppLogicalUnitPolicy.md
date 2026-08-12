# Vcenter.ViJson.OpenApi.Model.HostMultipathInfoHppLogicalUnitPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | **string** | String representing the path selection policy for a device.  Use one of the following strings: For NMP plugin - &lt;code&gt;VMW\\_PSP\\_FIXED&lt;/code&gt; - Use a preferred path whenever possible. - &lt;code&gt;VMW\\_PSP\\_RR&lt;/code&gt; - Load balance. - &lt;code&gt;VMW\\_PSP\\_MRU&lt;/code&gt; - Use the most recently used path.    For HPP plugin - &lt;code&gt;FIXED&lt;/code&gt; - Use a preferred path whenever possible. - &lt;code&gt;LB-RR&lt;/code&gt; - Load Balance - round robin. - &lt;code&gt;LB-IOPS&lt;/code&gt; - Load Balance - iops. - &lt;code&gt;LB-BYTES&lt;/code&gt; - Load Balance - bytes. - &lt;code&gt;LB- -Latency&lt;/code&gt; - Load balance - least latency.    You can also use the *HostStorageSystem.QueryPathSelectionPolicyOptions* method to retrieve the set of valid strings. Use the key from the resulting structure *HostPathSelectionPolicyOption*.  | 
**Bytes** | **long** | Byte count on the paths will be used as criteria to switch path for the device.  Allowed values 1 to (100\\*1024\\*1024) Default Value 10\\*1024\\*1024  | [optional] 
**Iops** | **long** | IOPS count on the paths will be used as criteria to switch path for the device.  Allowed values 1 to 10000 Default Value 1000  | [optional] 
**Path** | **string** | The preferred path for the given device.  If no preferred path is specified by the user, algorithm at ESX side will choose the random possible path.  | [optional] 
**LatencyEvalTime** | **long** | This value can control at what interval (in ms) the latency of paths should be evaluated.  Allowed values 10000 to (300 \\* 1000) in ms Default Value 30 \\* 1000  | [optional] 
**SamplingIosPerPath** | **long** | This value will control how many sample IOs should be issued on each path to calculate latency of the path.  Allowed values 16 to 160 Default Value 16  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

