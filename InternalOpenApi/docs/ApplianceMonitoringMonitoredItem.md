# Vcenter.Automation.OpenApi.Model.ApplianceMonitoringMonitoredItem
Appliance.Monitoring.MonitoredItem schema Structure representing requested monitored item data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | monitored item ID Ex: CPU, MEMORY  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.appliance.monitoring&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.appliance.monitoring&#x60;. | 
**Name** | **string** | monitored item name Ex: \&quot;Network write speed\&quot; | 
**Units** | **string** | Y-axis label EX: \&quot;Mbps\&quot;, \&quot;%\&quot; | 
**Category** | **string** | category Ex: network, storage etc | 
**Instance** | **string** | instance name Ex: eth0 | 
**Description** | **string** | monitored item description Ex: com.vmware.applmgmt.mon.descr.net.rx.packetRate.eth0 | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

