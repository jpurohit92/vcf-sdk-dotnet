# Vcenter.ViJson.OpenApi.Model.PerfMetricId

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CounterId** | **int** | The *ID* of the counter for the metric.  | 
**Instance** | **string** | An identifier that is derived from configuration names for the device associated with the metric.  It identifies the instance of the metric with its source. This property may be empty. - For memory and aggregated statistics, this property is empty. - For host and virtual machine devices, this property contains the   name of the device, such as the name of the host-bus adapter or   the name of the virtual Ethernet adapter. For example,   &amp;#147;mpx&amp;#46;vmhba33&amp;#58;C0&amp;#58;T0&amp;#58;L0&amp;#148; or   &amp;#147;vmnic0&amp;#58;&amp;#148; - For a CPU, this property identifies the numeric position within   the CPU core, such as 0, 1, 2, 3. - For a virtual disk, this property identifies the file type:   - DISKFILE, for virtual machine base-disk files   - SWAPFILE, for virtual machine swap files   - DELTAFILE, for virtual machine snapshot overhead files   - OTHERFILE, for all other files of a virtual machine  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

