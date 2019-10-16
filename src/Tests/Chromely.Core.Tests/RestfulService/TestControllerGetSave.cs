// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestControllerGetSave.cs" company="Chromely Projects">
//   Copyright (c) 2017-2019 Chromely Projects
// </copyright>
// <license>
//      See the LICENSE.md file in the project root for more information.
// </license>
// ----------------------------------------------------------------------------------------------------------------------

using Chromely.Core.RestfulService;

namespace Chromely.Core.Tests.RestfulService
{
    /// <summary>
    /// The test controller.
    /// </summary>
    [ControllerProperty(Name = "TestController", Route = "testcontroller")]
    public class TestControllerGetSave : ChromelyController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestControllerGetSave"/> class.
        /// </summary>
        public TestControllerGetSave()
        {
            RegisterGetRequest("/testcontroller/get1", Get1);
            RegisterGetRequest("/testcontroller/get2", Get2);
            RegisterPostRequest("/testcontroller/save", Save);
        }

        /// <summary>
        /// The get 1.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="ChromelyResponse"/>.
        /// </returns>
        private ChromelyResponse Get1(ChromelyRequest request)
        {
            var response = new ChromelyResponse { Data = 1000 };
            return response;
        }

        /// <summary>
        /// The get 2.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="ChromelyResponse"/>.
        /// </returns>
        private ChromelyResponse Get2(ChromelyRequest request)
        {
            var response = new ChromelyResponse { Data = "Test Get 2" };
            return response;
        }

        /// <summary>
        /// The save.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="ChromelyResponse"/>.
        /// </returns>
        private ChromelyResponse Save(ChromelyRequest request)
        {
            var response = new ChromelyResponse { Data = request.PostData };
            return response;
        }
    }
}