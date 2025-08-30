using MediatR;

namespace BuildingBlocks.CQRS
{
	//like void
	public interface ICommand : ICommand<Unit>
	{

	}
	public interface ICommand<out TResponse> :IRequest<TResponse>
	{
	}
}
