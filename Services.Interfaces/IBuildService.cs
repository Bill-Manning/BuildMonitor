﻿namespace BuildMonitor.Services.Interfaces
{
  /// <summary>
  /// Describes the expected features of a build server.
  /// </summary>
  public interface IBuildService
  {
    /// <summary>
    /// Returns the current status of the last build of the specified build configuration on the specified branch.
    /// </summary>
    /// <param name="connectionParams">The parameters required to connect to the build server.</param>
    /// <param name="buildConfigurationId">The unique identifier of the build configuration.</param>
    /// <param name="branchName">The name of the branch.</param>
    /// <returns>The status of the build.</returns>
    BuildResult GetLastBuildStatus(IConnectionParams connectionParams, string buildConfigurationId, string branchName);
  }
}
