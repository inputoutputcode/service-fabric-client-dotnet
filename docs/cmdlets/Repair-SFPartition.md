# Repair-SFPartition
Indicates to the Service Fabric cluster that it should attempt to recover a specific partition that is currently stuck in quorum loss.
## Description

This operation should only be performed if it is known that the replicas that are down cannot be recovered. Incorrect 
use of this API can cause potential data loss.



