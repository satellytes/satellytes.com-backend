#!/bin/bash
exec java -Djava.security.egd=file:/dev/./urandom -jar /app.jar -XX:+UnlockExperimentalVMOptions -XX:+UseCGroupMemoryLimitForHeap